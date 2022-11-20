double distance = 10000;
int firstFriendSpeed = 1;
int secondFriensSpeed = 2;
int dogSpeed = 5;
int Friend = 2;
int count = 0;
double time;
while(distance > 10)
{
    if(Friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        Friend = 2;
    }
    else
    {
        time = distance / (secondFriensSpeed + dogSpeed);
        Friend = 1;
    }
    distance = distance - (firstFriendSpeed+secondFriensSpeed)*time;
    count++;
}
Console.WriteLine(count); 
