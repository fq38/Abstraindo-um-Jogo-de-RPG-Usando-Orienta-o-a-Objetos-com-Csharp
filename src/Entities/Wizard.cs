namespace Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_Csharp.src.Entities
{
    public class Wizard : Hero
    {

        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Lancou Magia";
        }

        public string Attack(int Bonus){
            if(Bonus > 6){ 
                return this.Name + " Lancou magia Super efetiva com bonus de " + Bonus;
            }else{
                return this.Name + " Lancou uma magia com forca fraca com bonus de " + Bonus;
            }
        }



    }
}