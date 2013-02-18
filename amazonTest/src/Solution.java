import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.Arrays;


public class Solution {
	public static void main(String args[] ) throws Exception {
		/* Enter your code here. Read input from STDIN. Print output to STDOUT */
		//System.out.print("ok");
		try {
			int[] list1;
			//
			BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

			String s = br.readLine();
			String[] ss = s.split(" ");

			list1 = new int[ss.length];
			for(int j=0;j<ss.length;j++){
				list1[j] = Integer.parseInt(ss[j]);
			}
//			if(list1[0] > list1[list1.length-1])
//				swap(list1);

			// !!! the input is NOT always sorted!!!
			// have to add this
			Arrays.sort(list1);
			//
			int[] list2;

			//
			s = br.readLine();
			//System.out.println(s + "x");
			ss = s.split(" ");

			list2 = new int[ss.length];
			for(int j=0;j<ss.length;j++){
				list2[j] = Integer.parseInt(ss[j]);
			}
			if(list2[0] > list2[list2.length-1])
				swap(list2);
			Arrays.sort(list2);
			br.close();

			//
			int[] result = merge(list1, list2);
			for(int n: result)
			{
				System.out.print(n+" ");
			}

		} catch (Exception e) {
			System.err.println("Error:" + e);
		} 		
	}
	static void swap(int[] list)
	{
		for(int i = 0; i < list.length/2; i++)
		{
			int temp = list[i];
			list[i] = list[list.length - i - 1];
			list[list.length - i - 1] = temp;
		}

	}
	private static int[] readInput() {
		int[] list = null;
		try {
			BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

			String s = br.readLine();
			System.out.println(s + "x");
			String[] ss = s.split(" ");
			list = new int[ss.length];
			for(int j=0;j<ss.length;j++){
				list[j] = Integer.parseInt(ss[j]);
			}

			br.close();

		} catch (Exception e) {
			System.err.println("Error:" + e);
		}
		return list;
	}

	public static int[] merge(int[] list1, int[] list2) {
		if(list1==null && list2==null){
			return new int[]{};
		}
		else if(list1==null){
			return list2;
		}
		else if(list2==null){
			return list1;
		}


		int[] result = new int[list1.length + list2.length];
		int i = 0, j = 0, k = 0;
		while (i < list1.length && j < list2.length)
		{
			if (list1[i] < list2[j])
			{
				result[k] = list1[i];
				i++;
			}
			else
			{
				result[k] = list2[j];
				j++;
			}
			k++;
		}

		if(i<list1.length)
			System.arraycopy(list1,i,result,k,list1.length-i);
		else if(j<list2.length)
			System.arraycopy(list2,j,result,k,list2.length-j);

		return result;
	}
}


