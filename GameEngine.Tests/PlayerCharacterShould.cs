using System;
using Xunit;

namespace GameEngine.Tests
{
    public class PlayerCharacterShould
    {
        [Fact]
        public void BeInexperiencedWhenNew()
    
        {PlayerCharacter sut=new PlayerCharacter();
            Assert.True(sut.IsNoob);
            
        }

               [Fact]
        public void CalculateFullName()
    
        {PlayerCharacter sut=new PlayerCharacter();

            sut.FirstName="Sarah";
               sut.LastName="Smith";
             Assert.Equal("Sarah Smith",sut.FullName);
              

            
        }
                       [Fact]
        public void HaveFullNameStartingWithFirstName()
    
        {PlayerCharacter sut=new PlayerCharacter();

            sut.FirstName="Sarah";
               sut.LastName="Smith";
           
               Assert.StartsWith("Sarah",sut.FullName);

            
        }

                               [Fact]
        public void HaveFullNameEndingWithLastName()
    
        {PlayerCharacter sut=new PlayerCharacter();

            sut.FirstName="Sarah";
               sut.LastName="Smith";
           
               Assert.EndsWith("Smith",sut.FullName);

            
        }

                                      [Fact]
        public void CalculateFullName_IgnoreCaseAssertExample()
    
        {PlayerCharacter sut=new PlayerCharacter();

            sut.FirstName="Sarah";
               sut.LastName="Smith";
           
               Assert.Equal("SARAH SMITH",sut.FullName,ignoreCase:true);

            
        }

                                           [Fact]
        public void CalculateFullName_SubstringAssertExample()
    
        {PlayerCharacter sut=new PlayerCharacter();

            sut.FirstName="Sarah";
               sut.LastName="Smith";
           
               Assert.Contains("ah Sm",sut.FullName);

            
        }

                                                   [Fact]
        public void CalculateFullNamewithTitleCase()
    
        {PlayerCharacter sut=new PlayerCharacter();

            sut.FirstName="Sarah";
               sut.LastName="Smith";
           
               Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+",sut.FullName);

            
        }
                                                   [Fact]
        public void StartWithDefeaultHealth()
    
        {PlayerCharacter sut=new PlayerCharacter();

            Assert.Equal(100,sut.Health);

            
        }
                                                  [Fact]
        public void StartWithDefeaultHealth_NotEqual()
    
        {PlayerCharacter sut=new PlayerCharacter();

            Assert.NotEqual(0,sut.Health);

            
        }

                                                          [Fact]
        public void IncreaseHealthAfterSleeping()
    
        {PlayerCharacter sut=new PlayerCharacter();
            sut.Sleep();
           // Assert.True(sut.Health>=101 && sut.Health<=200);
              Assert.InRange<int>(sut.Health,101,200);

            
        }


        
    }
}
