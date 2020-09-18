using System;
using Xunit;

namespace GameEngine.Tests
{
    public class EnemyFactoryShould
    {
        [Fact]
        public void CreateNormalEnemyByDefault()
    
        {EnemyFactory sut=new EnemyFactory();
            Enemy enemy=sut.Create("Zombie");
            Assert.IsType<NormalEnemy>(enemy);
            
        }    [Fact]
                public void CreateBossEnemy()
    
        {EnemyFactory sut=new EnemyFactory();
            Enemy enemy=sut.Create("Zombie King",true);
            Assert.IsType<BossEnemy>(enemy);
                
        }    [Fact]
                    public void CreateBossEnemy_CastReturnedType()
    
        {EnemyFactory sut=new EnemyFactory();
            Enemy enemy=sut.Create("Zombie King",true);
           BossEnemy boss= Assert.IsType<BossEnemy>(enemy);
           Assert.Equal("Zombie King",boss.Name);
            
        }
         [Fact]
                    public void CreateBossEnemy_AssertAssignTypes()
    
        {EnemyFactory sut=new EnemyFactory();
            Enemy enemy=sut.Create("Zombie King",true);
           
           Assert.IsAssignableFrom<Enemy>(enemy);
            
        }
                [Fact]
                    public void CreateSeperateInstances()
    
        {EnemyFactory sut=new EnemyFactory();
            Enemy enemy=sut.Create("Zombie");
            Enemy enemy2=sut.Create("Zombie");
           
           Assert.NotSame(enemy,enemy2);
            
        }

                    [Fact]
                    public void NotAllowedNullName()
    
        {EnemyFactory sut=new EnemyFactory();
   
           
           Assert.Throws<ArgumentNullException>(()=>sut.Create(null));
            
        }

                        [Fact]
                    public void OnlyAllowKingOrKingBossEnemies()
    
        {EnemyFactory sut=new EnemyFactory();
   
           
           EnemyCreationException ex=Assert.Throws<EnemyCreationException>(()=>sut.Create("Zombie",true));
           Assert.Equal("Zombie",ex.RequestedEnemyName);
            
        }
        
        }
        
        
        }