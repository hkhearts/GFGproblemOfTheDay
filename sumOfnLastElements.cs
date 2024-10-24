class Solution {
  public:
    /*Structure of the node of the linled list is as

    struct Node {
        int data;
        struct Node* next;

        Node(int x){
            data = x;
            next = NULL;
        }
    };
    
    */
    // your task is to complete this function
    // function should return sum of last n nodes
    typedef struct Node* LIST;
    int sumOfLastN_Nodes(struct Node* head, int n) {
        // Code here
        //two pointers approach
        int sum = 0;
        int i = 0;
        LIST t1 = head;
        LIST t2 = head;
        
        while(i<n){
            if(t1==NULL){
                return 0;
            }
            t1 = t1->next;
            i++;
        }
        while(t1!=NULL){
            t1 = t1->next;
            t2 = t2->next;
        }
        while(t2 != NULL){
            sum = sum + t2->data;
            t2 = t2->next;
        }
        return sum;
        
    }
    
};
