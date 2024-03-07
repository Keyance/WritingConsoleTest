
using WritingConsoleTest;

Project danmachi = new Project("E:\\Text\\TrackerDemo\\Danmachi.txt", "Danmachi Project");

danmachi.Days.Add(new DateOnly(2024, 3, 1), 1182);
danmachi.Days.Add(new DateOnly(2024, 3, 2), 974);
danmachi.Days.Add(new DateOnly(2024, 3, 3), 1211);
danmachi.Days.Add(new DateOnly(2024, 3, 4), 826);
danmachi.Days.Add(new DateOnly(2024, 3, 5), 2492);
danmachi.Days.Add(new DateOnly(2024, 3, 6), 307);

double average = danmachi.GetAverage();
int sum = danmachi.GetSum();

Console.WriteLine(average + " - " + sum);