const divide = require('./divide');

test('3 divide by 2 equals 1.5', () => {
  expect(divide(3, 2)).toBe(1.5);
});

test("divide by zero throws error", () => {
  expect(() => divide(3, 0)).toThrow(Error);
});