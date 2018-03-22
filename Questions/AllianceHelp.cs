using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Questions
{
    public class Warrior
    {
        public int HP { get; set; }
        public int Attack { get; set; }
    }

    public class AllianceHelp
    {
        public int allianceHelp(int t, int allianceSize)
        {
            int boosts = 0;
            int tenth = (int) Math.Floor(t * 0.1);

            while (allianceSize > 0 && boosts < 10)
            {
                if (tenth > 60)
                {
                    t -= tenth;
                    allianceSize--;
                    boosts++;
                }
                else
                {
                    t -= 60;
                    allianceSize--;
                    boosts++;
                }
            }

            if (t < 0)
                return 0;
            return t;
        }

        public int allianceVersusMonster(int[] healthPoints, int[] attackDamage)
        {
            var monsterHP = healthPoints.First();
            var monsterAttack = attackDamage.First();

            var warriors = new List<Warrior>();
            for (var i = 1; i < healthPoints.Length; i++)
            {
                warriors.Add(new Warrior() {Attack = attackDamage[i], HP = healthPoints[i]});
            }


            while (monsterHP > 0)
            {
                // start with strongest alive warrior and hit until he is dead then move to next
                try
                {
                    var w = warriors.Where(warrior => warrior.HP > 0).OrderBy(warrior => warrior.Attack).First();


                    monsterHP -= w.Attack;
                    w.HP -= monsterAttack;
                    if (w.HP < 0)
                    {
                        warriors.Remove(w);
                    }

                    
                }
                catch (Exception e)
                {
                    return 0;
                }

            }
            return warriors.Count()+1;

        }
    }
}
