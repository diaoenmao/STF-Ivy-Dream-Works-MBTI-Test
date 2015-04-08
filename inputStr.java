import java.util.*;
import java.lang.*;
import java.io.*;

/* Name of the class has to be "Main" only if the class is public. */
public class main
{
	public static void main (String[] args) throws java.lang.Exception
	{
		for(int i=1;i<100;i+=4) {
			// remove the last ","
			System.out.println("string q"+i+", string q"+(i+1)+", string q"+(i+2)+", string q"+(i+3)+",");
		}
	}
}