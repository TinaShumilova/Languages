int count = 0;
double distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
bool friend = true;
double time = 0;

while(distance > 10)
{
    if(friend == true)
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = false;
        distance = distance - (firstFriendSpeed + secondFriendSpeed)*time;
        count = count + 1;
    }
    else
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = true;
        distance = distance - (firstFriendSpeed + secondFriendSpeed)*time;
        count = count + 1;
    }
}
Console.Write("Собака пробежала ");
Console.Write(count);
Console.WriteLine(" раз."); 