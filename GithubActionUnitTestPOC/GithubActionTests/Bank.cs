using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubActionTests
{
    public class Bank
    {
        private int currentMoney = 0;

        public void AddMoney(int value)
        {
            currentMoney += value;
        }

        public void SubstractMoney(int value)
        {
            currentMoney -= value;
        }

        public int CurrentMoney => currentMoney;
    }
}
