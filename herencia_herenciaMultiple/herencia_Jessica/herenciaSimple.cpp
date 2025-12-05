#include <iostream>

class Animal {
public:
  virtual ~Animal() = default;
  void respirar() const { std::cout << "Respirando" << std::endl; }
};

struct Perro : public Animal {
  void ladrar() const { std::cout << "Woof" << std::endl; }
};

struct Gato : public Animal {
  void miaullar() const { std::cout << "Miau" << std::endl; }
};

int main() {
  Perro p;
  Gato g;

  std::cout << "El perro: " << std::endl;
  p.respirar();
  p.ladrar();

  std::cout << "El gato: " << std::endl;
  g.respirar();
  g.miaullar();
}