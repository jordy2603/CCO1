using System;
using System.BO;
using System.IO;
using System.newtonsoft.Json;

namespace CC01.DAL
{
    class Ecole
    {
        private Ecole ecole;
        private const string FILE_NAME = @"ecole.json";
        private readonly string dbFolder;
        private FileInfo file;
        public Ecole(string dbFolder)
        {
            this.dbFolder = dbFolder;
            file = new FileInfo(Path.Combine(this.dbFolder, FILE_NAME));
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }
            if (!file.Exists)
            {
                file.Create().Close();
                file.Refresh();
            }
            if (file.Length > 0)
            {
                using (StreamReader sr = new StreamReader(file.FullName))
                {
                    string json = sr.ReadToEnd();
                    ecole = JsonConvert.DeserializeObject<Ecole>(json);
                }
            }
        }

        public void Add(Ecole ecole)
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(ecole);
                sw.WriteLine(json);
            }
        }

        public Ecole Get()
        {
            return ecole;
        }
    }
}
