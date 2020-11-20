

using Newtonsoft.Json;
using System;
using System.BO;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;


namespace CC01.DAL
{
    public class EtudiantDAO
    {

        private static List<EtudiantDAO> etudiant;
        private const string FILE_NAME = @"etudiant.json";
        private readonly string dbFolder;
        private FileInfo file;
        private object RemoveEtudiant;

        public EtudiantDAO(string dbFolder)
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
                using (StreamReader sr = new StreamReader(file.Nom))
                {
                    string json = sr.ReadToEnd();
                    etudiant = JsonConvert.DeserializeObject<List<EtudiantDAO>>(json);
                }
            }
            if (etudiant == null)
            {
                etudiant = new List<EtudiantDAO>();
            }
        }

        public void Set(EtudiantDAO oldEtudiant, EtudiantDAO newEtudiant)
        {
            var oldIndex = etudiant.IndexOf(oldEtudiant);
            var newIndex = etudiant.IndexOf(newEtudiant);
            if (oldIndex < 0)
                throw new KeyNotFoundException("l'etudiant n'existe pas !");
            if (newIndex >= 0 && oldIndex != newIndex)
                throw new DuplicateNameException("This student reference already exists !");
            etudiant[oldIndex] = newEtudiant;
            Save();
        }

        public void Add(EtudiantDAO Etudiant)
        {
            var index = .IndexOf(etudiant);
            if (index >= 0)
                throw new DuplicateNameException("This student reference already exists !");
            etudiant.Add(Etudiant);
            Save();
        }

        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(etudiant);
                sw.WriteLine(json);
            }
        }

        public void Remove(EtudiantDAO etudiant)
        {
            etudiant.Remove(etudiant);//base sur Product.Equals redefini
            Save();
        }

        public IEnumerable<EtudiantDAO> Find()
        {
            return new List<EtudiantDAO>(
                etudiant);
        }

        public IEnumerable<EtudiantDAO> Find(Func<EtudiantDAO, bool> predicate)
        {
            return new List<EtudiantDAO>(etudiant.Where(predicate).ToArray());
        }
    }
}

    

