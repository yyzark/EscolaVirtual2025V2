using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual2025.Classes.Academic
{
    public class SchoolCard
    {
        private int m_saldo;
        private int m_schoolCardId;

        public int Saldo
        {
            get { return m_saldo; }
            set { m_saldo = value; }
        }

        public int SchoolCardId
        {
            get { return m_schoolCardId; }
            set { m_schoolCardId = value; }
        }

        public SchoolCard(int SchoolCardId)
        {
            this.m_saldo = 0;
            this.m_schoolCardId= SchoolCardId;
        }

        public void Deposit(decimal montanteEmEuros)
        {
            m_saldo += Convert.ToInt32(montanteEmEuros * 100);
        }
    }
}
