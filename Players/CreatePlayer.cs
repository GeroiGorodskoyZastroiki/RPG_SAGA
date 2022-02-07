namespace RpgSaga.Players;

public class CreatePlayers{
    public CreatePlayers(){
        List<Player> players = new List<Player>();
    }
    public List<Player> players = new List<Player>();
    public void AddPlayerToList(Player player){
        this.players.Add(player);
    }

    public void CreatePlayersList(){
        Int32.TryParse(Console.ReadLine(), out int playersCount);
        Random rnd = new Random();
        int randomClassOfPlayer = 0;
        while(playersCount != 0){
            randomClassOfPlayer = rnd.Next(0, 3);
            switch(randomClassOfPlayer){
                case 0:
                    AddPlayerToList(new Archer());
                    break;
                case 1:
                    AddPlayerToList(new Knight());
                    break;
                case 2:
                    AddPlayerToList(new Wizard());
                    break;
            }
            playersCount -= 1;
        }
    }
}