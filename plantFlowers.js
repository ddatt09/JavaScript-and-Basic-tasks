/**
 * 
 * Cho một vườn hoa tương ứng với dãy arr gồm các số 0, 1. Vị trí mà có số 1 sẽ đại diện cho mảnh đất đã được dùng để trồng hoa. Còn số 0 đại diện cho mảnh đất trống. Hiện tại bạn đang có n bông hoa. Hãy tính toán xem có thể trồng được n bông hoa trên mảnh đất đó không, sao cho các vị trí ngay bên cạnh không có bông hoa nào.

Ví dụ:

Với arr = [1, 0, 0, 0, 1], n = 1. Đầu ra plantFlowers(arr) = true.
     Giải thích: Ta có thể trồng một bông hoa ở vị trí 2 (vị trí bắt đầu là vị trí 0)

Với arr = [1, 0, 0, 0, 1], n = 2. Đầu ra plantFlowers(arr) = false.

 */

function plantFlowers(arr, n) {
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] == 0) {
            if (arr[i + 1] != 1 && arr[i - 1] != 1) {
                arr[i] = 1;
                n -= 1;
            }
        }
        if (n == 0) return true;
    }
    return false;
}

console.log(plantFlowers(arr, n));
