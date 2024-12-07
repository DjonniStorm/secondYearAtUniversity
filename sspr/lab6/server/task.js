class Task {
    static calculate(matrix) {
        // TODO: check if array is not typeof number only
        if (!Array.isArray(matrix) || matrix.length === 0 || !Array.isArray(matrix[0])) {
            throw new Error('Invalid matrix');
        }

        let min = matrix[0][0];

        for (let i = 0; i < matrix.length; ++i) {
            for (let j = 0; j < matrix[i].length; ++j) {
                if (matrix[i][j] < min) {
                    min = matrix[i][j];
                }
            }
        }

        return min;
    }
}

module.exports = Task;