public class Player
{
    private string name;
    private Room currentRoom;
    public float playerHitPoints;
    public float playerArmorClass;
    public float playerAttack;

    void Start()
    {
        System.Random rand = new System.Random();
        int randomNumber = rand.Next(11);
        this.playerHitPoints = 10 + randomNumber;
        int randomNumber2 = rand.Next(8);
        this.playerArmorClass = 10 + randomNumber2;
        int randomnumber3 = rand.Next(5);
        this.playerAttack = 1 + randomnumber3;

    }

    public Player(string name)
    {
        this.name = name;
    }

    public Room getCurrentRoom()
    {
        return this.currentRoom;
    }

    public void setCurrentRoom(Room r)
    {
        if (r != null)
        {
            this.currentRoom = r;
        }
    }

    //getter (accessor) for read only access to the private field name
    public string getName()
    {
        return this.name;
    }

}