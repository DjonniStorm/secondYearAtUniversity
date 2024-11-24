#pragma once
using matrix = std::vector<std::vector<int>>;

struct RouteAndFitness {
	std::vector<int> route;
	double fitness;
};

std::ostream& operator<<(std::ostream& out, std::vector<int>& vec) {
	out << " [";
	for (int i = 0; i < vec.size(); ++i) {
		out << vec[i];
		if (i < vec.size() - 1) {
			out << ", ";
		}
	}
	out << "]";
	return out;
}

std::ostream& operator<<(std::ostream& out, std::vector<std::vector<int>>& vec) {
	out << " [";
	for (int i = 0; i < vec.size(); ++i) {
		out << vec[i];
		if (i < vec.size() - 1) {
			out << ", ";
		}
	}
	out << "]";
	return out;
}

std::ostream& operator<<(std::ostream& out, RouteAndFitness &raf) {
	out << "best variant" << raf.route << " fitness score " << raf.fitness << std::endl;
	return out;
}


matrix create_population(int size, int num_points);

std::vector<int> crossover_one_point(const std::vector<int>& parent1, const std::vector<int>& parent2);
std::vector<int> crossover_two_point(const std::vector<int>& parent1, const std::vector<int>& parent2);

std::vector<int> mutate(std::vector<int> route, double mutation_rate);

double fitness(const std::vector<int>& route, const matrix& distance_matrix, const std::vector<int>& preferences);

RouteAndFitness genetic_algo(
	matrix &distance_matrix, 
	std::vector<int> &preferences, 
	int size, 
	int generations,
	float mutation_rate
);
