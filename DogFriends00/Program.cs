// Задача про двух друзей и собаку


Console.WriteLine("Программа посчитает, сколько раз собака пробежит между двумя друзьями, пока они идут друг другу навстречу. ");
Console.Write("Укажите дистанцию между друзьями: ");

int distance = Convert.ToInt32(Console.ReadLine());

int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;

int count = 0;
int friend = 2;
int time = 0;

while (distance > 10)
    {

        if (friend == 1)
            {
            time = distance / (firstFriendSpeed + dogSpeed);
            friend = 2;
            }
        else
            {
            time = distance / (secondFriendSpeed + dogSpeed);
            friend = 1;
            }

    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;

    count++;

    }

Console.WriteLine($"Собака пробежит {count} раз ");