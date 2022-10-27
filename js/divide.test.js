const divide = require('./divide');

test('3 divide by 2 equals 1.5', () => {
  expect(divide(3, 2)).toBe(1.5);
});