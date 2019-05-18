#include <iostream>

using namespace std;
class Node
{
public:
	Node *Next;
	Node *Prev;

	int value;


	void Print(Node* node)
	{
		Node* temp = node;
		if (node != NULL)
		{
			while (node->Next != NULL)
			{
				cout << (node->value ) << "-> ";
				node = node->Next;
			}
			cout << endl;
		
		}

	}

	void PrintPrev(Node* node)
	{
		Node* temp = node;
		if (node != NULL)
		{
			
			while (temp->Prev != NULL)
			{
				cout << (temp->value) << "<- ";
				temp = temp->Prev;
			}
		}

	}
	void Reverse(Node* Head)
	{

	}

	void Swap(Node* node)
	{
		if (node->Next->Next != NULL)
		{
			Swap(node->Next);
		}
	
		node->Next->Next = node;
		//עבור רשימה דו כיוונית
		node->Prev = node->Next;

	}
};


int main()
{

	Node* Head;
	Node* Tail;

	Head = new Node();
	Node* a = Head;
	a->Prev == NULL;
	for (int i = 0; i < 10; i++)
	{
		a->value = i;
		a->Next = new Node();
		a->Next->Prev = a;
		a = a->Next;
	}

	Tail = a;
	Tail->Next = NULL;


	Head->Print(Head);
	Head->Swap(Head);
	
	Head->Next = NULL;
	Tail->Prev = NULL;
	Node* temp = Head;
	Head = Tail;
	Tail = temp;
	cout << endl;

	Head->Print(Head);
	Head->PrintPrev(Tail);

	getchar();
	return 0;
}