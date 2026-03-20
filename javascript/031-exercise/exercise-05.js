function calculateTriangleArea(a, b, c) {
    let p = (a + b + c) / 2;
    return Math.sqrt(p * (p - a) * (p - b) * (p - c))
}

console.log(calculateTriangleArea(3, 4, 5))