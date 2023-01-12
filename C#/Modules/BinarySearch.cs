public static class BinarySearch{
    // array is sorted and contains distinct numbers
    // if no target found return -1
    public static int Find(this int[] arr, int target){
        int lo = 0, hi = arr.Length-1;
        while(lo <= hi){
            int mid = lo + (hi-lo)/2;
            if(arr[mid] == target) return mid;
            if(arr[mid] > target){
                hi = mid-1;
            } else{
                lo = mid+1;
            }
        }
        return -1;
    }
}