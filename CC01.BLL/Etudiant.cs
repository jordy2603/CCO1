using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BLL
{
    class Etudiant


        Etudiant etudiantRepo;
    public Etudiant(string dbFolder)
    {
        etudiantRepo = new Etudiant(dbFolder);
    }
    public void CreateEtudiant(Etudiant etudiant
        )
    {
       etudiantRepo.Add(etudiant);
    }

    public void DeleteEtudiant(etudiant etudiant)
    {
        etudiantRepo.Remove(etudiant);
    }


    public IEnumerable<Etudiant> GetAllEtudiant()
    {
        return etudiantRepo.Find();
    }


    public IEnumerable<Etudiant> GetByReference(string reference)
    {
        return etudiantRepo.Find(x => x.Reference == reference);
    }

    public IEnumerable<Etudiant> GetBy(Func<Etudiant, bool> predicate)
    {
        return etudiantRepo.Find(predicate);
    }

    public void EditProduct(Product oldProduct, Product newProduct)
    {
        productRepo.Set(oldProduct, newProduct);
    }
}
}
