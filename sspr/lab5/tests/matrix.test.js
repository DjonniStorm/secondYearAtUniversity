const Task = require('../public/task');

describe('Task', () => {

    test('Матрица 2 * 2. Правильный результат = 3', () => {
        const matrix = [
            [1, 2],
            [3, 4]
        ];
        const result = Task.calculate(matrix);
        expect(result).toBe(3);
    });

    test('Матрица 3 * 3. Правильный результат = 4', () => {
        const matrix = [
            [1, 2, 3],
            [4, 5, 6],
            [7, 8, 9]
        ];

        const result = Task.calculate(matrix);
        expect(result).toBe(4);
    });

    test('Матрица 4 * 4. Правильный результат = -8', () => {
        const matrix = [
            [ 1, -2,  3, 4],
            [-4,  5, -6, 5],
            [ 7, -8,  9, 7],
            [ 7, -8,  9, 9]
        ];
        const result = Task.calculate(matrix);
        expect(result).toBe(-8);
    });

    test('Ошибка, если нельзя посчитать ниже главной диагонали', () => {
        const matrix = [[1]];
        expect(() => Task.calculate(matrix)).toThrow('Невозможно посчитать');
    });
});
