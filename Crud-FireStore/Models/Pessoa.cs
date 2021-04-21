using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_FireStore.Models
{
    [FirestoreData]
    public class Pessoa
    {
        public string PessoaId { get; set; }

        [FirestoreProperty]
        public string Nome { get; set; }

        [FirestoreProperty]
        public string Idade { get; set; }
    }
}
