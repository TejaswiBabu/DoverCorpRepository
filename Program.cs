using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace Practice
{
    class Teacherdata
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sub { get; set; }
        public string Location { get; set; }
    }




    class Code
    {

        static void Main(string[] args)
        {
            string fpath = @"C:\Project\Teachers_records.txt";
            List<Teacherdata> teachers = new List<Teacherdata>();
            Console.WriteLine("Welcome to Rainbow School! ");




            while (true)
            {
                Console.WriteLine("Choose any option to perform the operation");
                Console.WriteLine("1.Display all the teacher records\n2.Add teacher to the record \n3.Delete teacher record\n4.Update teacher record\n5.Get Teacher record using ID\n6.Exit");
                int Key = System.Convert.ToInt32(Console.ReadLine());

                



                switch (Key)
                {
                    //DISPLAY ALLL THE TEACHER RECORDS
                    case 1:


                        List<string> lines = File.ReadAllLines(fpath).ToList();
                        foreach (var line in lines)
                        {
                            string[] input = line.Split(',');
                            Teacherdata newTeacher = new Teacherdata();
                            
                                if(input==null)
                            {
                                Console.WriteLine("No data found");
                            }
                                else
                                //if (input.Length == 4)
                                {
                                    newTeacher.Id = Convert.ToInt32(input[0]);
                                    newTeacher.Name = input[1];
                                    newTeacher.Sub = input[2];
                                    newTeacher.Location = input[3];
                                    teachers.Add(newTeacher);


                                    Console.WriteLine("================================================================");
                                    Console.WriteLine($"ID: {newTeacher.Id}, Name: {newTeacher.Name}, Subject: {newTeacher.Sub}, Class: {newTeacher.Location}\n");

                                }

                            }
                            
                        
                        continue;

                    //ADD TEACHER TO THE RECORD

                    case 2:
                        Console.WriteLine("===================================================");
                        Console.WriteLine("ADD TEACHER DETAILS");
                        Console.WriteLine("===================================================");
                        Console.WriteLine("Enter Teacher ID: ");
                        int tid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Teacher Name");
                        string tname = Console.ReadLine();
                        Console.WriteLine("Enter the subject");
                        string tsub = Console.ReadLine();
                        Console.WriteLine("Enter the Location");
                        string tloc = Console.ReadLine();

                        teachers.Add(new Teacherdata { Id = tid, Name = tname, Sub = tsub, Location = tloc });

                        List<string> output = new List<string>();
                        foreach (var item in teachers)
                        {
                            output.Add($"{item.Id},{item.Name},{item.Sub},{item.Location}");
                        }
                        File.AppendAllLines(fpath, output);
                        continue;

                    //DELETE TEACHER FROM THE RECORD

                    case 3:
                        Console.WriteLine("===================================================");
                        Console.WriteLine("DELETE TEACHER RECORD");
                        Console.WriteLine("===================================================");
                        Console.WriteLine("Enter the Teacher ID to delete from the record");
                        string tdelete = Console.ReadLine();
                        try
                        {
                            List<string> files = new List<string>(System.IO.File.ReadAllLines(fpath));
                            List<string> newfile = new List<string>();
                            foreach (var item in files)
                            {
                                if (item.StartsWith(tdelete))
                                {

                                }
                                else
                                {
                                    newfile.Add(item);
                                    File.WriteAllLines(fpath, newfile.ToArray());

                                }
                            }
                        }
                        catch (Exception err)
                        {
                            Console.WriteLine("Exception Occurred" + err.Message);
                        }

                        continue;

                    //UPDATE TEACHER RECORD

                    case 4:
                        Console.WriteLine("===================================================");
                        Console.WriteLine("UPDATE TEACHER RECORD");
                        Console.WriteLine("===================================================");
                        Console.WriteLine("Enter the Teacher ID to update the record");
                        string tupdate = Console.ReadLine();
                        List<string> update = new List<string>(System.IO.File.ReadAllLines(fpath));
                        List<string> updated = new List<string>();
                        foreach (var item in update)
                        {
                            if (item.StartsWith(tupdate))
                            {
                                Teacherdata entry = new Teacherdata();
                                Console.WriteLine("Enter Teacher details to update");
                                Console.WriteLine("================================================");
                                Console.WriteLine("Enter Teacher Name");
                                string name = Console.ReadLine();
                                Console.WriteLine($"Enter the Subject");
                                string sub = Console.ReadLine();
                                Console.WriteLine($"Enter the Location");
                                string tloca = Console.ReadLine();
                                teachers.Add(new Teacherdata { Id = Convert.ToInt32(tupdate), Name = name, Sub = sub, Location = tloca });
                                foreach (var items in teachers)
                                {
                                    updated.Add($"{items.Id},{items.Name},{items.Sub},{items.Location}");
                                }
                                File.WriteAllLines(fpath, updated.ToArray());
                            }
                            else
                            {
                                updated.Add(item);
                                File.WriteAllLines(fpath, updated.ToArray());
                            }

                        }
                        continue;

                    //GET TEACHER DETAILS BY ID

                    case 5:
                        Console.WriteLine("===================================================");

                        Console.WriteLine("GET TEACHER DETAILS BY ID");
                        Console.WriteLine("===================================================");
                        Console.WriteLine("Enter the Teacher ID: ");
                        List<string> file = new List<string>(System.IO.File.ReadAllLines(fpath));
                        string tdata = Console.ReadLine();
                        foreach (var item in file)
                        {
                            if (item.StartsWith(tdata))
                            {
                                string[] entries = item.Split(',');
                                Teacherdata choice = new Teacherdata();
                                choice.Id = Convert.ToInt32(entries[0]);
                                choice.Name = entries[1];
                                choice.Sub = entries[2];
                                choice.Location = entries[3];
                                Console.WriteLine($"ID: {choice.Id}, Name: {choice.Name}, Subject: {choice.Sub}, Class: {choice.Location}\n");
                            }
                        }

                        continue;

                    case 6:

                        goto exit_loop;
                        //break;
                        




                    default:
                        Console.WriteLine("Invalid input!!");
                        continue;


                }

            exit_loop:
                break;

            }

        


        }
    }

}
