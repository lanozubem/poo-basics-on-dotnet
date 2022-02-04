namespace dotnet_poo.src.Entities
{
    public  class Mutant: Common
    {
        public override string Talk()
        {
            return $"{Name}: I am a Super Mutant! I am unstoppable!";
        }
    }
}