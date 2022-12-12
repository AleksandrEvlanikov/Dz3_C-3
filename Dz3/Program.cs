int i,ctr;
    Console.Write("Введите число : ");
    ctr= Convert.ToInt32(Console.ReadLine());	
    for( i=1; i<=ctr; i++)
    {
	 Console.Write("{2} \n",i,i, (i*i*i));     
    }
