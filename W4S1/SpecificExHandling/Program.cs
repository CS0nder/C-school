


    using Newtonsoft.Json;

    class Program
    {
        public static void Main()
        {   try
            {   
                
          
                string fileName = "People.json";
                using (StreamReader reader = new(fileName));
                string File2Json = reader.ReadToEnd();
                List<Person> listOfObjects = JsonConvert.DeserializeObject<List<Person>>(File2Json)!;
                reader.Close();
            
                foreach (Person p in listOfObjects)
                {
                    foreach (Car c in p.OwnedCars)
                    {   
                        for (int i = 0; i < 5; i++)
                        {
                            c.Drive();
                        }
                    }
                    }   
                
                using (StreamWriter writer = new(fileName));
                string List2Json = JsonConvert.SerializeObject(listOfObjects);
                writer.Write(List2Json);
                
            }  
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"Missing JSON file {e.Message}");
            }        
            catch (JsonReaderException e)
            {
                Console.WriteLine($"Invalid JSON {e.Message}");
            }

            catch (IOException e)
            {
                Console.WriteLine($"io exception: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception occurred: {e.Message}");
            }
            finally
            {
                Close();
            }

            
        }
    }
