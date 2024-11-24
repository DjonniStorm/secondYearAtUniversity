#include <iostream>
#include <vector>
#include <numeric>
#include <random>
#include <algorithm>
#include "Header.h";

int main() {
	std::srand(static_cast<unsigned int>(std::time(0)));
	matrix initial_population = {
		{ 0, 10, 15, 20 },
		{ 10, 0, 35, 25 },
		{ 15, 35, 0, 30 },
		{ 20, 25, 30, 0 },
	};

	std::vector<int> preferences = { 10, 8, 6, 9 };
	std::vector<int> population_size = { 20, 100, 1000 };
	
	int generations = 100;

	float mutation_rate = 0.1;

	std::cout << "start" << std::endl;

	for (auto &size : population_size) {
		auto route_and_fitness = genetic_algo(
			initial_population,
			preferences,
			size,
			generations,
			mutation_rate
		);
		std::cout << route_and_fitness;
	}

	return 0;
}


RouteAndFitness genetic_algo(
	matrix& distance_matrix,
	std::vector<int>& preferences,
	int population_size,
	int generations,
	float mutation_rate
) {

	matrix population = create_population(
		population_size, distance_matrix.size());

	//std::cout << population;
	for (int generation = 0; generation < generations; ++generation) {
		std::sort(population.begin(), population.end(),
			[&](const std::vector<int>& a, const std::vector<int>& b) {
				return fitness(a, distance_matrix, preferences) > fitness(b, distance_matrix, preferences);
			}
		);

		std::vector<std::vector<int>> new_population(population.begin(), population.begin() + population_size / 2);

		while (new_population.size() < population_size) {
			std::vector<int> parent1 = population[rand() % (population_size / 2)];
			std::vector<int> parent2 = population[rand() % (population_size / 2)];
			std::vector<int> child;

			child = ( rand() % 10 > 4 )
				? crossover_one_point(parent1, parent2) 
				: child = crossover_two_point(parent1, parent2);

			child = mutate(child, mutation_rate);
			new_population.push_back(child);
		}

		population = new_population;
	}
	auto best_route = *std::max_element(population.begin(), population.end(),
		[&](const std::vector<int>& a, const std::vector<int>& b) {
		return fitness(a, distance_matrix, preferences) < fitness(b, distance_matrix, preferences);
	});
	return RouteAndFitness{
		best_route,
		fitness(best_route, distance_matrix, preferences)
	};
}

matrix create_population(int size, int num_points) {
	matrix population(size, std::vector<int>(num_points));
	std::iota(population[0].begin(), population[0].end(), 0);
	for (int i = 1; i < size; ++i) {
		population[i] = population[0];
		std::shuffle(population[i].begin(), population[i].end(), std::random_device()); // Перемешиваем
	}
	return population;
}

double fitness(const std::vector<int>& route, const matrix& distance_matrix, const std::vector<int>& preferences) {
	double total_distance = 0;
	double total_preference = 0;

	for (int i = 0; i < route.size() - 1; ++i) {
		total_distance += distance_matrix[route[i]][route[i + 1]];
		total_preference += preferences[route[i]];
	}
	total_preference += preferences[route.back()]; // Добавляем предпочтение последней точки

	return total_preference / total_distance; // Максимизируем предпочтение при минимизации расстояния
}


std::vector<int> crossover_one_point(const std::vector<int>& parent1, const std::vector<int>& parent2) {
	int point = rand() % (parent1.size() - 1) + 1;
	std::vector<int> child(parent1.begin(), parent1.begin() + point);
	for (int gene : parent2) {
		if (find(child.begin(), child.end(), gene) == child.end()) {
			child.push_back(gene);
		}
	}
	return child;
}

std::vector<int> crossover_two_point(const std::vector<int>& parent1, const std::vector<int>& parent2) {
	int start = rand() % parent1.size();
	int end = rand() % parent1.size();
	if (start > end) {
		std::swap(start, end);
	}
	std::vector<int> child(parent1.begin() + start, parent1.begin() + end);
	for (int gene : parent2) {
		if (find(child.begin(), child.end(), gene) == child.end()) {
			child.push_back(gene);
		}
	}
	return child;
}

std::vector<int> mutate(std::vector<int> route, double mutation_rate) {
	for (size_t i = 0; i < route.size(); ++i) {
		if (std::rand() / static_cast<double>(RAND_MAX) < mutation_rate) {
			int j = rand() % route.size();
			std::swap(route[i], route[j]);
		}
	}
	return route;
}
