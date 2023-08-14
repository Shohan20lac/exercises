// Online C++ compiler to run C++ program online
#include <iostream>
#include <list>

struct Node {
    int data;
    struct Node* next;
    struct Node* prev;
};

struct Node* head = NULL;
struct Node* tail = NULL;
    
void insertAtTail (int inval){
    std::cout << "Inserting " << inval << " to list...\n";
    Node* newNode = new Node;
    newNode -> data = inval;
    
    // case1: List is empty
    if (head == NULL){
        std::cout << "List is empty\n";
        head = newNode;
        
        
        newNode -> next = NULL;
        newNode -> prev = NULL;
        
        std::cout << "Head node created. Address:" << head << std::endl;
    }
    
    // case2: List has only one element
    else if (head-> next==NULL){
        std::cout << "List has only one element\n";
        
        head -> next = newNode;
        
        newNode -> prev = head;
        newNode -> next = NULL;
        
        std::cout << "New node added at Tail. Address:" << tail << std::endl;
    }
    
    // case3: List has more than one element
    else {
        std::cout << "List has more than one element. Initializing iterator...\n";
        Node* nodeIterator = head;
        while (nodeIterator -> next != NULL){
            std::cout << ".\n";
            nodeIterator = nodeIterator -> next;
        }
        nodeIterator -> next = newNode;
    }
    
    tail = newNode;
    
}

void printAllNodesSequentially (Node* current) {
    while (current!= NULL){
        std::cout << current -> data;
        current = current -> next;
    }
}

void display() {
   struct Node* ptr;
   ptr = head;
   while (ptr != NULL) {
      std::cout<< ptr->data <<" ";
      ptr = ptr->next;
   }
   
   std::cout << std::endl;
}


int main() {
    insertAtTail (10);
    display();

    insertAtTail (1);
    display();
    
    insertAtTail (3);
    display();

    return 0;
}