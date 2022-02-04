namespace dotnet_poo.src.Entities
{
    public class Human : Common
    {
        public override string Talk()
        {
            return $"{Name}: I'm a Human!";
        }

        public string Attack(string opponent, int bonus)
        {
            if(bonus > 6){
                return $"{Name} atacou {opponent} com bonus de ataque crítico de 2x{bonus}";
            }else{
                return $"{Name} atacou {opponent} com bonus de ataque de {bonus} pontos";
            }
        }
    }
}