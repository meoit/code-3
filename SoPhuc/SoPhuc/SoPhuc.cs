using System;
using System.Collections.Generic;
using System.Text;

namespace SoPhuc
{
    class SoPhuc
    {
        private int thuc, ao;

        public int Thuc
        {
            get
            {
                return thuc;

            }
        }
        public int Ao
        {
            get
            {
                return ao;
            }
        }
        public SoPhuc(int thuc, int ao)
        {
            this.thuc = thuc;
            this.ao = ao;
        }
        public static SoPhuc operator +(SoPhuc a, SoPhuc b)
        {
            SoPhuc p = new SoPhuc(a.thuc + b.thuc, a.ao + b.ao);
            return p;
        }
        public static SoPhuc operator -(SoPhuc a, SoPhuc b)
        {
            SoPhuc p = new SoPhuc(a.thuc - b.thuc, a.ao - b.ao);
            return p;
        }
        public static SoPhuc operator *(SoPhuc a, SoPhuc b)
        {
            SoPhuc p = new SoPhuc(a.thuc * b.thuc - a.ao * b.ao, a.thuc * b.ao + b.thuc * a.ao);
            return p;
        }
        public static SoPhuc operator /(SoPhuc a, SoPhuc b)
        {
            SoPhuc p = new SoPhuc((a.thuc * b.thuc + a.ao * b.ao) / (b.thuc * b.thuc + b.ao * b.ao), (a.ao * b.thuc - a.thuc * b.ao) / (b.thuc * b.thuc + b.ao * b.ao));
            return p;
        }
        public void In(SoPhuc p)
        {
            Console.WriteLine("Phan thuc: " + p.thuc);
            Console.WriteLine("Phan ao: " + p.ao);
        }
    }
    
}
