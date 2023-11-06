using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indekseri2
{
    internal class Student
    {
        string jmbag;
        public string Jmbag => jmbag;
        byte[,] bodovi;
        public Student(string jmbag, byte[,] bodovi)
        {
            this.jmbag = jmbag;
            this.bodovi = bodovi;
        }
        public Student(string jmbag) : this(jmbag,
            new byte[3, 2])
        { }
        public byte this[int i, int j]
        {
            get => bodovi[i - 1, j - 1];
            set => bodovi[i - 1, j - 1] = value;
        }
        public string this[int i]
        {
            get
            {
                int ukupno = 0;
                for (int j = 0; j < bodovi.GetLength(1); ++j)
                    ukupno += bodovi[i - 1, j];
                return $"{jmbag}, DZ{i}: {ukupno} bodova";
            }
        }
        public override string ToString()
        {
            string poruka = $"Podaci za studenta {jmbag}:\n";
            for (int i = 0; i < bodovi.GetLength(0); ++i)
            {
                poruka += $"\tDZ{i + 1}: ";
                for (int j = 0; j < bodovi.GetLength(1); j++)
                {
                    poruka += $"\t{bodovi[i, j]}";
                }
                poruka += '\n';
            }
            return poruka;
        }
    }
    internal class Kolegij
    {
        string naziv, sifra;
        Student[][] rezultati;
        public string this[string jmbag]
        {
            get
            {
                foreach (Student[] grupa in rezultati)
                {
                    foreach(Student student in grupa)
                    {
                        if(student.Jmbag == jmbag)
                            return student.ToString();
                    }
                }
                return "Nema podataka o studentu.";
            }
        }
        public Kolegij(string naziv, string sifra)
        {
            this.naziv = naziv;
            this.sifra = sifra;
            rezultati = new Student[2][];
        }
        public Student[] this[int i]
        {
            get => rezultati[i];
            set => rezultati[i] = value;
        }
        public Student[] this[Index i]
            => rezultati[i];
        public Student[][] this[Range r]
            => rezultati[r];
    }
}
