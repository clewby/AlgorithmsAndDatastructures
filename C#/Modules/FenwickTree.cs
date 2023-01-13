class FenwickTree{
    private int _treeSize;
    private int[] _treeArray;
    
    // O(n) init time
    public FenwickTree(int[] arr){
        this._treeSize = arr.Length;
        this._treeArray = new int[arr.Length+1];
        for(int i = 1; i <= arr.Length; i++){
            this._treeArray[i] += arr[i-1];
            int j = i + (i&(-i));
            if(j <= this._treeSize){
                this._treeArray[j] += this._treeArray[i];
            }
        }
    }
    // O(logn) update time
    public void Update(int delta, int index){
        int i = index+1;
        while(i <= this._treeSize){
            this._treeArray[i] += delta;
            i += (i&(-i));
        }
    }
    // O(logn) query time
    public int Sum(int index){
        int sum = 0, i = index+1;
        while(i > 0){
            sum += this._treeArray[i];
            i -= (i&(-i));
        }
        return sum;
    }
}