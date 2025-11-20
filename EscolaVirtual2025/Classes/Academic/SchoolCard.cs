using System;

namespace EscolaVirtual2025.Classes.Academic
{
    public class SchoolCard
    {
        private int m_saldo;
        private int m_schoolCardId;

        public int Saldo
        {
            get => m_saldo;
            set => m_saldo = value;
        }

        public int SchoolCardId
        {
            get => m_schoolCardId;
            set => m_schoolCardId = value;
        }

        public SchoolCard(int schoolCardId)
        {
            m_schoolCardId = schoolCardId;
            m_saldo = 0;
        }

        public void Deposit(decimal montanteEmEuros)
        {
            m_saldo += Convert.ToInt32(montanteEmEuros * 100);
        }
    }
}
