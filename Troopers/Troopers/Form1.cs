using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Troopers
{
    public partial class Form1 : Form
    {
        private List<Trooper> allTroopers;
        private List<Trooper> mainTroopers;

        private Dictionary<string, List<Trooper>> squadTroopers = new Dictionary<string, List<Trooper>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var troopers = LoadTroopers();

            EvaluateTroopers(troopers);

            allTroopers = new List<Trooper>(troopers.OrderBy(x => x.Accuracy));
            mainTroopers = new List<Trooper>(allTroopers);

            listBoxTroopers.RefreshDataSource(mainTroopers, nameof(Trooper.Name));            
        }
        
        private void EvaluateTroopers(List<Trooper> troopers)
        {
            var random = new Random();

            foreach(var troop in troopers)
            {
                troop.Accuracy = random.Next(0, 10) + 1;
            }
        }

        private List<Trooper> LoadTroopers()
        {
            var troopers = new List<Trooper>();
            StreamReader reader = null;
            try
            {
                reader = new StreamReader("TrooperList.json");
                var outputJson = reader.ReadToEnd();
                troopers = JsonConvert.DeserializeObject<List<Trooper>>(outputJson);                
            }
            catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
            finally
            {
                if(reader != null)
                {
                    reader.Close();
                    reader.Dispose();
                }
            }

            return troopers;
        }

        private void textBoxTrooperSearch_TextChanged(object sender, EventArgs e)
        {
            mainTroopers = allTroopers.Where(x => x.Name.ToUpper().Contains(textBoxTrooperSearch.Text.ToUpper())).ToList();
            listBoxTroopers.RefreshDataSource(mainTroopers, nameof(Trooper.Name));                
        }

        private void buttonAddTrooperForSquad_Click(object sender, EventArgs e)
        {
            string squadName = textBoxSquadName.Text;
            var trooper = GetTrooperFromList();

            if(trooper != null)
            {
                if (!string.IsNullOrWhiteSpace(squadName))
                {
                    AddOrUpdateTrooper(squadName, trooper);
                }
                else
                {
                    MessageBox.Show(Messages.MessageNotEmpty);
                }
            }            
            else
            {
                MessageBox.Show(Messages.MessageNotEmpty);
            }
        }

        private void AddOrUpdateTrooper(string squadName, Trooper trooper)
        {
            if (squadTroopers.ContainsKey(squadName))
            {
                squadTroopers[squadName].Add(trooper);
            }
            else
            {
                var trooperList = new List<Trooper>();
                trooperList.Add(trooper);
                squadTroopers.Add(squadName, trooperList);
            }

            allTroopers.Remove(trooper);
            mainTroopers.Remove(trooper);
            listBoxTroopers.RefreshDataSource(mainTroopers, nameof(Trooper.Name));
            RefreshSquadTroopers(squadName);
        }

        private void RefreshSquadTroopers(string squadName)
        {
            if(squadTroopers.ContainsKey(squadName))
            {
                listBoxSquadTeam.RefreshDataSource(squadTroopers[squadName], nameof(Trooper.Name));                
            }
            else
            {
                listBoxSquadTeam.RefreshDataSource(new List<Trooper>(), string.Empty);
            }
        }

        private Trooper GetTrooperFromList()
        {
            if(listBoxTroopers.SelectedIndex != -1)
            {
                return (Trooper)listBoxTroopers.SelectedItem;
            }
            return null;
        }

        private void textBoxSquadName_TextChanged(object sender, EventArgs e)
        {
            RefreshSquadTroopers(textBoxSquadName.Text);
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = null;
                try
                {
                    writer = new StreamWriter(saveFileDialog1.FileName);
                    var trooperSquadsJson = JsonConvert.SerializeObject(squadTroopers);
                    writer.WriteLine(trooperSquadsJson);
                }
                catch(Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex);
                }
                finally
                {
                    if(writer != null)
                    {
                        writer.Close();
                        writer.Dispose();
                    }
                }                
            }
        }
    }
}
