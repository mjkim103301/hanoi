//�ϳ���ž_ Queue Breadth First Search
//�ʱ����
//3, 2, 1
//0, 0, 0
//0, 0, 0

#include <iostream>
#include <queue>

using namespace std;
static int number = 0;//��� ����������
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
				cout << "��!!!" << endl;
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
	//�� ���� ���ڰ� ������ ����ĭ �� ������ ����
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

	//��� ĭ�� ���ڰ� ������ �ٴںκ� ��������� ����. �ٴںκ��� ������� ������ �ٴ� �κ��� �� ���� �ø��� �ִ��� �Ǵ���. 3�� ��ġ�� �ű� �� �ִ��� �Ǵ���.
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

	//���� 2�ٿ� ���ڰ� ������ �ٴںκ� ���ڵ��� �� �� �����ϸ� ���� �ø�
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

