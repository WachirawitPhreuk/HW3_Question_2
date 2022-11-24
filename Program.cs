class Program
{
    static void Main(string[] args)
    {
        Queue<int> q = new Queue<int>();
        while(true) {
            char fruit = char.Parse(Console.ReadLine());
            if (fruit == 'L') {
                q.Push(1);
            }
            else if (fruit == 'M') {
                q.Push(2);
            }
            else if (fruit == 'S') {
                q.Push(3);
            }
            else {break;}
            }
        
        while(q.GetLength()!=0) {
            int fruit = q.Pop();
            Console.Write(fruit);

            if(fruit == 1) {
                q.Push(2);
                q.Push(2);
            }
            
            if(fruit ==2) {
                q.Push(3);
                q.Push(3);
                q.Push(3);
            }
        }
    }
}