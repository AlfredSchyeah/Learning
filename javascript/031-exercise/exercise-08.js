function scalarProduct(a, b) {
    return a[0] * b[0] + a[1] * b[1] + a[2] * b[2];
}
const array1 = [1, 2, 3]
const array2 = [4, 5, 6]
console.log(scalarProduct(array1, array2))

const array3 = [-2, 3, 5]
const array4 = [1, -3, 2]
console.log(scalarProduct(array3, array4))