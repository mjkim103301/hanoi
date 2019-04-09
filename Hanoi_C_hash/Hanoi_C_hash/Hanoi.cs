using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Hanoi_C_hash
{
   class Hanoi
    {
        Queue<int[][]> q = new Queue<int[][]>();
        Stack<int> s = new Stack<int>();

        int number;//하노이탑의 수
        int s_index = -1;//stack의 인덱스
        int[] s_arr = new int[100000];//일차원 배열에 부모의 인덱스 값들을 넣음.
        int last = 0;//목표값의 인덱스
        int original = 0;//처음으로 목표값에 도달한 인덱스만을 받기 위해.
        int count = 0;
        Form1 form;
        public Hanoi()
        {
            DoubleBuffering d = DoubleBuffering.getinstance();
        }
        public void set_number(object box, int n)
        {
            number = n;
        }
        public int get_number()
        {
            return number;
        }
        public int set_count()
        {
            count++;
            return count;
        }

        void printarr(int[][] a)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j <= number; j++)
                {
                    Console.WriteLine(a[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        void print_G_List(int[][][] G_List, int index)
        {
            return;
            printarr(G_List[index]);
            Console.WriteLine();

        }

        void getG_List(int[][] a, int[][][] G_List, int index, int s_index)
        {

            index++;

            G_List[index] = a;
            s_arr[index] = s_index;

            if (a[2][1] == number && a[2][number] == 1)
            {
                if (original == 1)
                    return;
                last = index;
                original++;
            }
        }

        void main()
        {
            //Console.Write("하노이탑의 수를  입력하세요: ");

            //number=int.Parse(Console.ReadLine());
            //number = Check_txt.Text;
          //  number = int(form.Check_txt_TextChanged);
            int[][] array = new int[3][];
            int[][] a;
            int[][][] G_List = new int[100000][][];
            int index = -1;//G_List의 인덱스
            int result;
            


            for (int i = 0; i < 3; i++)
            {
                array[i] = new int[number + 1];

            }
            for (int j = 0; j < number; j++)
            {
                array[0][j + 1] = number - j;
            }

            for (int i = 1; i < 3; i++)
                for (int j = 1; j <= number; j++)
                    array[i][j] = 0;
            array[0][0] = number;
            array[1][0] = 0;
            array[2][0] = 0;

            getG_List(array, G_List, index, s_index);
            print_G_List(G_List, index);

            //printarr(array);

            q.Enqueue(array);

            while (q.Count!=0)
            {
                a = q.Dequeue();
                s_index++;
                if (a[2][1] == number && a[2][number] == 1)
                {
                    index = last;
                    while (s_arr[index] != -1)
                    {

                        s.Push(s_arr[index]);
                        index = s_arr[index];
                        //	cout << index << endl;
                    }
                    while (s.Count != 0)
                    {
                        result = s.Pop();
                        set_count();
                       
                        //cout << count << "번째" << endl;
                        printarr(G_List[result]);
                    }
                    set_count();
                    //cout << count << "번째" << endl;
                    printarr(G_List[last]);

                    Console.WriteLine("끝!!!");
                    return;
                }
                Sons(a, index, G_List);
            }
        }

        int[][] copyarray(int[][] a)
        {
            int[][] copy = new int[3][];
            for (int i = 0; i < 3; i++)
            {
                copy[i] = new int[number + 1];
                for (int j = 0; j <= number; j++)
                {
                    copy[i][j] = a[i][j];
                }
            }
            return copy;
        }

        //같으면 false
        bool check_same(int[][][] G_List, int index, int[][] copy)
        {
            bool b = true; // 다르면 true
            for (int i = 0; i <= index; i++)
            {
                if (b)
                {
                    b = false;

                    for (int j = 0; j < 3; j++)
                    {
                        for (int k = 0; k <= number; k++)
                        {
                            if (G_List[i][j][k] != copy[j][k])
                            {
                                b = true;
                            }
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        void arrange(int[][] copy, int[][] a, int[][][] G_List, int index)
        {

            if (check_same(G_List, index, copy))
            {
                getG_List(copy, G_List, index, s_index);
                print_G_List(G_List, index);
                q.Enqueue(copy);
            }
            //printarr(copy);

        }
        void Sons(int[][] a, int index, int[][][] G_List)
        {
            int[][] copy = copyarray(a);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 1; j < 3; j++)
                {
                    if (copy[i][0] > 0 && copy[(i + j) % 3][0] == 0)//바닥에 아무것도 없을때
                    {
                        int targetindex = copy[i][0];
                        int goalline = (i + j) % 3;
                        copy[goalline][1] = copy[i][targetindex];
                        copy[i][targetindex] = 0;
                        copy[i][0]--;
                        copy[goalline][0]++;
                        arrange(copy, a, G_List, index);
                        copy = copyarray(a);

                    }
                    else if (copy[i][0] > 0 && copy[i][copy[i][0]] < copy[(i + j) % 3][copy[(i + j) % 3][0]])//숫자를 옮길 수 있는지 확인
                    {
                        copy[(i + j) % 3][copy[(i + j) % 3][0] + 1] = copy[i][copy[i][0]];
                        copy[i][copy[i][0]] = 0;
                        copy[i][0]--;
                        copy[(i + j) % 3][0]++;

                        arrange(copy, a, G_List, index);

                        copy = copyarray(a);

                    }
                    continue;
                }
            }
        }
    }
}
