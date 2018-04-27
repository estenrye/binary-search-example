using System;
using System.Collections.Generic;
namespace binary_search_example
{
    public class Node
    {
        public int value { get; set; }
        public Node left { get; set; }
        public Node right { get; set; }
        public void print(){
            Console.WriteLine($" {value} ");
        }

        public void search(int searchValue) {
            if (this.value == searchValue)
            {
                print();
            }
            if (this.left != null && this.left.value >= searchValue)
            {
                this.left.search(searchValue);
            }
            if (this.right != null && this.right.value <= searchValue)
            {
                this.right.search(searchValue);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var tree = 
                new Node {
                    value=1,
                    left=new Node {
                        value=4,
                        left=null,
                        right=null
                    },
                    right=new Node {
                        value=5,
                        left=new Node {
                            value=5,
                            left=new Node {
                                value=5,
                                left=null,
                                right=null
                            },
                            right=new Node {
                                value=6,
                                left=null,
                                right=null
                            }
                        },
                        right=new Node {
                            value=13,
                            left=new Node {
                                value=15,
                                left=new Node {
                                    value=15,
                                    left=null,
                                    right=null
                                },
                                right=new Node {
                                    value=25,
                                    left=null,
                                    right=null
                                }
                            },
                        }
                    }
                };
            Console.WriteLine("Hello World!");
            tree.search(5);
        }
    }
}
