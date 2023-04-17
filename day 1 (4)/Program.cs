int N = 12345; // замените на свое значение
int secondsInHour = 60 * 60;
int secondsSinceLastHour = N % secondsInHour;
Console.WriteLine("Количество секунд, прошедших с начала последнего часа: " + secondsSinceLastHour);
