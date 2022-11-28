

using StackAndQueueProblems;
////UC1
StackPushOperation obj = new StackPushOperation();
obj.push(70);
obj.push(30);
obj.push(56);

obj.display();

////UC2
StackPOpAndPeakOperation obj2 = new StackPOpAndPeakOperation();
obj2.push(70);
obj2.push(30);
obj2.push(56);
obj2.TillEmpty();

//UC3
Queue_EnqueueOperation obj3 = new Queue_EnqueueOperation();
obj3.Enqueue(56);
obj3.Enqueue(30);
obj3.Enqueue(70);

obj3.display();

//UC4
Queue_DequeueOperation obj4 = new Queue_DequeueOperation();
obj4.Enqueue(56);
obj4.Enqueue(30);
obj4.Enqueue(70);

obj4.Dequeue();
