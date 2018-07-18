/*
 After getting her PhD, Christie has become a celebrity at her university, and her facebook profile is full of friend requests. Being the nice girl she is, Christie has accepted all the requests.

Now Kuldeep is jealous of all the attention she is getting from other guys, so he asks her to delete some of the guys from her friend list.

To avoid a 'scene', Christie decides to remove some friends from her friend list, since she knows the popularity of each of the friend she has, she uses the following algorithm to delete a friend.

Algorithm Delete(Friend):
    DeleteFriend=false
    for i = 1 to Friend.length-1
         if (Friend[i].popularity < Friend[i+1].popularity)
            delete i th friend
            DeleteFriend=true
            break
    if(DeleteFriend == false)
        delete the last friend

Input: 
First line contains T number of test cases. First line of each test case contains N, the number of friends Christie currently has and K ,the number of friends Christie decides to delete. Next lines contains popularity of her friends separated by space.

Output: 
For each test case print N-K numbers which represent popularity of Christie friend's after deleting K friends.

Constraints
1<=T<=1000
1<=N<=100000
0<=K< N 
0<=popularity_of_friend<=100

NOTE:
Order of friends after deleting exactly K friends should be maintained as given in input.
 */


using System;
using System.Collections.Generic;
using System.Linq;


namespace Remove_Friend
{
    class Program
    {
        static void Main(string[] args)
        {
            int test_case = Int32.Parse(Console.ReadLine());
            while (test_case > 0)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                long friend_count = Int32.Parse(inputs[0]);
                long no_of_deletes = Int32.Parse(inputs[1]);

                LinkedList<int> friends = new LinkedList<int>(Console.ReadLine().Trim().Split(' ').Select(int.Parse));
                LinkedListNode<int> current = friends.First;
                while (no_of_deletes > 0)
                {
                    while ((current.Next != null) && (current.Value >= current.Next.Value))
                    {
                        current = current.Next;
                    }
                    if (current.Next == null)
                        break;

                    LinkedListNode<int> deleteNode = current;
                    current = current.Previous ?? current.Next;
                    friends.Remove(deleteNode);
                    no_of_deletes--;
                }
                if (no_of_deletes > 0)
                {
                    friends.Remove(friends.Last);
                }

                Console.WriteLine(string.Join(" ", friends));

                test_case--;
            }
        }
    }
}

