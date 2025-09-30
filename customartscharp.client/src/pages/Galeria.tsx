"use client"
import { useState } from "react";
import { Search, SlidersHorizontal, Star } from "lucide-react";
import { Input } from "@/components/ui/input";
import { Button } from "@/components/ui/button";
import { Card, CardContent, CardDescription, CardFooter, CardHeader, CardTitle } from "@/components/ui/card";
import { Badge } from "@/components/ui/badge";
import {
  Select,
  SelectContent,
  SelectItem,
  SelectTrigger,
  SelectValue,
} from "@/components/ui/select";
import { Link } from "react-router-dom";

interface Product {
  id: number;
  title: string;
  artist: string;
  price: number;
  category: string;
  featured: boolean;
  image: string;
  rating: number;
}

// Dados de exemplo
const products: Product[] = [
  {
    id: 1,
    title: "Pôr do Sol Abstrato",
    artist: "Maria Silva",
    price: 450.00,
    category: "abstrato",
    featured: true,
    image: "/placeholder.svg",
    rating: 5
  },
  {
    id: 2,
    title: "Paisagem Urbana",
    artist: "João Santos",
    price: 380.00,
    category: "paisagem",
    featured: true,
    image: "/placeholder.svg",
    rating: 4.8
  },
  {
    id: 3,
    title: "Retrato Moderno",
    artist: "Ana Costa",
    price: 520.00,
    category: "retrato",
    featured: true,
    image: "/placeholder.svg",
    rating: 4.9
  },
  {
    id: 4,
    title: "Natureza Viva",
    artist: "Pedro Lima",
    price: 320.00,
    category: "natureza",
    featured: false,
    image: "/placeholder.svg",
    rating: 4.5
  },
  {
    id: 5,
    title: "Composição Geométrica",
    artist: "Laura Mendes",
    price: 480.00,
    category: "abstrato",
    featured: false,
    image: "/placeholder.svg",
    rating: 4.7
  },
  {
    id: 6,
    title: "Oceano Azul",
    artist: "Carlos Rocha",
    price: 410.00,
    category: "paisagem",
    featured: false,
    image: "/placeholder.svg",
    rating: 4.6
  },
];

const Gallery = () => {
  const [searchTerm, setSearchTerm] = useState("");
  const [categoryFilter, setCategoryFilter] = useState("todos");
  const [priceFilter, setPriceFilter] = useState("todos");
  const [showFilters, setShowFilters] = useState(false);

  const featuredProducts = products.filter(p => p.featured);

  const filteredProducts = products.filter(product => {
    const matchesSearch = product.title.toLowerCase().includes(searchTerm.toLowerCase()) ||
                         product.artist.toLowerCase().includes(searchTerm.toLowerCase());
    const matchesCategory = categoryFilter === "todos" || product.category === categoryFilter;
    const matchesPrice = priceFilter === "todos" || 
                        (priceFilter === "baixo" && product.price < 400) ||
                        (priceFilter === "medio" && product.price >= 400 && product.price < 500) ||
                        (priceFilter === "alto" && product.price >= 500);
    
    return matchesSearch && matchesCategory && matchesPrice;
  });

  return (
    <div className="min-h-screen bg-background">
      {/* Header */}
      <header className="border-b bg-card">
        <div className="container mx-auto px-4 py-4 flex items-center justify-between">
          <Link to="/" className="text-2xl font-bold text-primary hover:text-primary/80 transition-colors">
            Custom Art Creator
          </Link>
        </div>
      </header>

      <main className="container mx-auto px-4 py-8">
        {/* Hero Section */}
        <section className="mb-12 text-center">
          <h1 className="text-4xl md:text-5xl font-bold text-foreground mb-4">
            Galeria de Arte
          </h1>
          <p className="text-lg text-muted-foreground max-w-2xl mx-auto">
            Explore nossa coleção exclusiva de obras de arte personalizadas
          </p>
        </section>

        {/* Featured Products */}
        <section className="mb-12">
          <div className="flex items-center gap-2 mb-6">
            <Star className="w-6 h-6 text-primary fill-primary" />
            <h2 className="text-3xl font-bold text-foreground">Produtos em Destaque</h2>
          </div>
          
          <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">
            {featuredProducts.map((product) => (
              <Card key={product.id} className="overflow-hidden hover:shadow-lg transition-shadow">
                <div className="relative">
                  <img 
                    src={product.image} 
                    alt={product.title}
                    className="w-full h-64 object-cover"
                  />
                  <Badge className="absolute top-4 right-4 bg-primary text-primary-foreground">
                    Destaque
                  </Badge>
                </div>
                <CardHeader>
                  <CardTitle className="text-xl">{product.title}</CardTitle>
                  <CardDescription className="flex items-center gap-2">
                    <span>{product.artist}</span>
                    <span className="flex items-center gap-1 text-primary">
                      <Star className="w-4 h-4 fill-primary" />
                      {product.rating}
                    </span>
                  </CardDescription>
                </CardHeader>
                <CardFooter className="flex items-center justify-between">
                  <span className="text-2xl font-bold text-primary">
                    R$ {product.price.toFixed(2)}
                  </span>
                  <Button>Ver Detalhes</Button>
                </CardFooter>
              </Card>
            ))}
          </div>
        </section>

        {/* Search and Filters */}
        <section className="mb-8">
          <div className="flex flex-col md:flex-row gap-4 items-start md:items-center justify-between">
            {/* Search Bar */}
            <div className="relative flex-1 w-full md:max-w-md">
              <Search className="absolute left-3 top-1/2 transform -translate-y-1/2 w-5 h-5 text-muted-foreground" />
              <Input
                type="text"
                placeholder="Buscar por título ou artista..."
                value={searchTerm}
                onChange={(e) => setSearchTerm(e.target.value)}
                className="pl-10"
              />
            </div>

            {/* Filter Toggle */}
            <Button
              variant="outline"
              onClick={() => setShowFilters(!showFilters)}
              className="gap-2"
            >
              <SlidersHorizontal className="w-4 h-4" />
              Filtros
            </Button>
          </div>

          {/* Filter Options */}
          {showFilters && (
            <div className="mt-4 p-6 border rounded-lg bg-card">
              <div className="grid grid-cols-1 md:grid-cols-2 gap-4">
                <div>
                  <label className="block text-sm font-medium mb-2 text-foreground">
                    Categoria
                  </label>
                  <Select value={categoryFilter} onValueChange={setCategoryFilter}>
                    <SelectTrigger>
                      <SelectValue placeholder="Selecione uma categoria" />
                    </SelectTrigger>
                    <SelectContent>
                      <SelectItem value="todos">Todas as Categorias</SelectItem>
                      <SelectItem value="abstrato">Abstrato</SelectItem>
                      <SelectItem value="paisagem">Paisagem</SelectItem>
                      <SelectItem value="retrato">Retrato</SelectItem>
                      <SelectItem value="natureza">Natureza</SelectItem>
                    </SelectContent>
                  </Select>
                </div>

                <div>
                  <label className="block text-sm font-medium mb-2 text-foreground">
                    Faixa de Preço
                  </label>
                  <Select value={priceFilter} onValueChange={setPriceFilter}>
                    <SelectTrigger>
                      <SelectValue placeholder="Selecione uma faixa" />
                    </SelectTrigger>
                    <SelectContent>
                      <SelectItem value="todos">Todos os Preços</SelectItem>
                      <SelectItem value="baixo">Até R$ 400</SelectItem>
                      <SelectItem value="medio">R$ 400 - R$ 500</SelectItem>
                      <SelectItem value="alto">Acima de R$ 500</SelectItem>
                    </SelectContent>
                  </Select>
                </div>
              </div>
            </div>
          )}
        </section>

        {/* All Products Grid */}
        <section>
          <h2 className="text-3xl font-bold text-foreground mb-6">
            Todos os Produtos ({filteredProducts.length})
          </h2>
          
          {filteredProducts.length === 0 ? (
            <div className="text-center py-12">
              <p className="text-lg text-muted-foreground">
                Nenhum produto encontrado com os filtros selecionados.
              </p>
            </div>
          ) : (
            <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 xl:grid-cols-4 gap-6">
              {filteredProducts.map((product) => (
                <Card key={product.id} className="overflow-hidden hover:shadow-lg transition-shadow">
                  <div className="relative">
                    <img 
                      src={product.image} 
                      alt={product.title}
                      className="w-full h-48 object-cover"
                    />
                    {product.featured && (
                      <Badge className="absolute top-3 right-3 bg-primary text-primary-foreground">
                        Destaque
                      </Badge>
                    )}
                  </div>
                  <CardHeader>
                    <CardTitle className="text-lg line-clamp-1">{product.title}</CardTitle>
                    <CardDescription className="flex items-center justify-between">
                      <span className="line-clamp-1">{product.artist}</span>
                      <span className="flex items-center gap-1 text-primary">
                        <Star className="w-3 h-3 fill-primary" />
                        {product.rating}
                      </span>
                    </CardDescription>
                  </CardHeader>
                  <CardContent>
                    <Badge variant="secondary" className="mb-3">
                      {product.category}
                    </Badge>
                  </CardContent>
                  <CardFooter className="flex flex-col gap-2">
                    <span className="text-xl font-bold text-primary w-full text-left">
                      R$ {product.price.toFixed(2)}
                    </span>
                    <Button className="w-full">Ver Detalhes</Button>
                  </CardFooter>
                </Card>
              ))}
            </div>
          )}
        </section>
      </main>

      {/* Footer */}
      <footer className="border-t mt-12 py-8 bg-card">
        <div className="container mx-auto px-4 text-center text-muted-foreground">
          <p>© 2024 Custom Art Creator. Todos os direitos reservados.</p>
        </div>
      </footer>
    </div>
  );
};

export default Gallery;
