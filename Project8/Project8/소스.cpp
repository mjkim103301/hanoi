//하노이탑_ Queue Breadth First Search
//초기상태
//3, 2, 1
//0, 0, 0
//0, 0, 0

#include <iostream>
#include <queue>

using namespace std;
static int number = 0;//몇번 움직였는지
static queue<int**>q;
void Sons(int **a);



void printarr(int **a) {
	for (int i = 0; i < 3; i++) {
		for (int j = 0; j < 3; j++) {
			cout << a[i][j] << " ";
		}
		cout << endl;
	}
	cout << endl;
}

int main()
{
	int **array = new int*[3];
	int **a;

	for (int i = 0; i < 3; i++)
	{
		array[i] = new int[3];
		array[0][i] = 3 - i;
	}
	for (int i = 1; i <= 2; i++)
		for (int j = 0; j <= 2; j++)
			array[i][j] = 0;



	q.push(array);

	while (!q.empty())
	{
		a = q.front();
		q.pop();
		printarr(a);
		for (int i = 1; i <= 2; i++)
		{
			if (a[i][0] == 3 && a[i][1] == 2 && a[i][2] == 1)
			{
				cout << "끝!!!" << endl;
				return 0;
			}
		}

		Sons(a);
		//delete[] a;
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

void Sons(int **a)

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
				q.push(copy);
				copy = copyarray(a);
			}


		}
	}

	//가운데 칸에 숫자가 있을때 바닥부분 빈공간으로 내림. 바닥부분이 비어있지 않을때 바닥 부분을 맨 위로 올릴수 있는지 판단함. 3의 위치를 옮길 수 있는지 판단함.
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
					q.push(copy);
					copy = copyarray(a);
				}
				else if (copy[i][1] > copy[(i + j) % 3][0] && copy[(i + j) % 3][0] != 0)
				{
					copy[i][2] = copy[(i + j) % 3][0];
					copy[(i + j) % 3][0] = 0;
					q.push(copy);
					copy = copyarray(a);
				}
				else if (copy[i][1] < copy[(i + j) % 3][0])
				{
					for (int k = 0; k <= 2; k++)
						if (copy[k][0] == 0 && k != (i + j) % 3)
						{
							copy[k][0] = copy[(i + j) % 3][0];
							copy[(i + j) % 3][0] = 0;
							q.push(copy);
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
					q.push(copy);
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

