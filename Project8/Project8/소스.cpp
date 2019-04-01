//하노이탑_ Queue Breadth First Search
//초기상태
//3, 2, 1
//0, 0, 0
//0, 0, 0

#include <iostream>
#include <queue>
#include<stack>
using namespace std;

static queue<int**>q;
void Sons(int **a, int &index, int***G_List);
static stack<int>s;

int s_index = -1;//stack 의 인덱스
int *s_arr = new int[101];//일차원 배열에 부모의 인덱스 값들을 넣음.
int last;
void printarr(int **a) {
	for (int i = 0; i < 3; i++) {
		for (int j = 0; j < 3; j++) {
			cout << a[i][j] << " ";
		}
		cout << endl;
	}
	cout << endl;
}

void print_G_List(int ***G_List, int index)
{
	return;//안쓸꺼니까
	printarr(G_List[index]);

	cout << endl;

}

void getG_List(int **a, int***G_List, int &index, int &s_index) {

	index++;
	G_List[index] = a;
	s_arr[index] = s_index;
	//cout << s_index<<endl;
	if (a[2][0] == 3 && a[2][1] == 2 && a[2][2] == 1)
	{
		last = index;
	}

}



int main()
{
	int **array = new int*[3];

	int **a;

	int result;

	int ***G_List = new int **[101];
	int index = -1;//G_List의 인덱스



	for (int i = 0; i < 3; i++)
	{
		array[i] = new int[3];
		array[0][i] = 3 - i;
	}
	for (int i = 1; i <= 2; i++)
		for (int j = 0; j <= 2; j++)
			array[i][j] = 0;


	getG_List(array, G_List, index, s_index);//G_List 에 배열 넣기
	print_G_List(G_List, index);//G_List의 배열을 프린트하기
	q.push(array);

	while (!q.empty())
	{
		a = q.front();
		q.pop();
		s_index++;

		if (a[2][0] == 3 && a[2][1] == 2 && a[2][2] == 1)
		{
			index = last;
			while (s_arr[index] != -1)
			{

				s.push(s_arr[index]);
				index = s_arr[index];
				//cout << index << endl;
			}
			while (!s.empty())
			{
				result = s.top();
				s.pop();
				printarr(G_List[result]);
			}
			printarr(G_List[last]);
			cout << "끝!!!" << endl;
			return 0;
		}


		Sons(a, index, G_List);


	}
}

int** copyarray(int **a)
{
	int **copy = new int*[3];
	for (int i = 0; i < 3; i++)
	{
		copy[i] = new int[3];
		for (int j = 0; j < 3; j++) {
			copy[i][j] = a[i][j];
		}
	}return copy;
}

//같으면 false
bool check_same(int ***G_List, int &index, int **copy)
{
	bool b = true; // 다르면 true
	for (int i = 0; i <= index; i++)
	{
		if (b) {
			b = false;

			for (int j = 0; j < 3; j++)
			{
				for (int k = 0; k < 3; k++)
				{
					if (G_List[i][j][k] != copy[j][k])
					{
						b = true;
					}
				}
			}
		}
		else {
			return false;
		}
	}
	return true;
}

void Sons(int **a, int &index, int ***G_List)

{
	int **copy = copyarray(a);
	//맨 위에 숫자가 있을때 다음칸 맨 밑으로 내림
	for (int i = 0; i <= 2; i++)
	{

		if (copy[i][2] != 0)
		{
			for (int j = 1; j <= 2; j++)
			{
				copy[(i + j) % 3][0] = copy[i][2];
				copy[i][2] = 0;


				if (check_same(G_List, index, copy))
				{
					getG_List(copy, G_List, index, s_index);//G_List 에 배열 넣기
					print_G_List(G_List, index);
					q.push(copy);

				}
				copy = copyarray(a);





			}


		}
	}

	//가운데 칸에 숫자가 있을때 바닥부분 빈공간으로 내림. 바닥부분이 비어있지 않을때 바닥 부분을 맨 위로 올릴수 있는지 판단함.
	//3의 위치를 옮길 수 있는지 판단함.
	for (int i = 0; i <= 2; i++)
	{
		if (copy[i][2] == 0 && copy[i][1] != 0)
		{
			for (int j = 1; j <= 2; j++)
			{
				if (copy[(i + j) % 3][0] == 0)
				{
					copy[(i + j) % 3][0] = copy[i][1];
					copy[i][1] = 0;
					if (check_same(G_List, index, copy))
					{
						getG_List(copy, G_List, index, s_index);//G_List 에 배열 넣기
						print_G_List(G_List, index);
						q.push(copy);


					}
					copy = copyarray(a);
				}
				else if (copy[i][1] > copy[(i + j) % 3][0] && copy[(i + j) % 3][0] != 0)
				{
					copy[i][2] = copy[(i + j) % 3][0];
					copy[(i + j) % 3][0] = 0;
					if (check_same(G_List, index, copy))
					{
						getG_List(copy, G_List, index, s_index);//G_List 에 배열 넣기
						print_G_List(G_List, index);
						q.push(copy);

					}
					copy = copyarray(a);
				}
				else if (copy[i][1] < copy[(i + j) % 3][0])
				{
					for (int k = 0; k <= 2; k++)
						if (copy[k][0] == 0 && k != (i + j) % 3)
						{
							copy[k][0] = copy[(i + j) % 3][0];
							copy[(i + j) % 3][0] = 0;
							if (check_same(G_List, index, copy))
							{
								getG_List(copy, G_List, index, s_index);//G_List 에 배열 넣기
								print_G_List(G_List, index);
								q.push(copy);


							}
							copy = copyarray(a);
						}
						else
							continue;

				}
				else
					continue;
			}

		}
	}

	//위의 2줄에 숫자가 없을때 바닥부분 숫자들을 비교 후 가능하면 위로 올림
	for (int i = 0; i <= 2; i++)
	{
		for (int j = 1; j <= 2; j++)
		{
			if (copy[0][1] == 0 && copy[0][2] == 0 && copy[1][1] == 0 && copy[1][2] == 0 && copy[2][1] == 0 && copy[2][2] == 0)
			{
				if (copy[i][0] < copy[(i + j) % 3][0])
				{
					copy[(i + j) % 3][1] = copy[i][0];
					copy[i][0] = 0;
					if (check_same(G_List, index, copy))
					{
						getG_List(copy, G_List, index, s_index);//G_List 에 배열 넣기
						print_G_List(G_List, index);
						q.push(copy);


					}
					copy = copyarray(a);


				}
				else
					continue;
			}
			else
				continue;
		}
	}

}

