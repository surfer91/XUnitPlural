using System;
using Xunit;

namespace GameEngine.Tests
{
    public class BossenemyShould
    {
        [Fact]
        public void HaveCorrectPower()
    
        {BossEnemy sut=new BossEnemy();
            Assert.Equal(166.67,sut.TotalSpecialAttackPower,3);
            
        }
        
        
        }
        
        
        }