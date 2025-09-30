import { Link } from 'react-router-dom';
import { Button } from '@/components/ui/button';
import { LoginDropdown } from './Auth/LoginDropdown';

export default function Header() {
  return (
    <header className="bg-background/95 backdrop-blur-sm border-b border-border sticky top-0 z-50">
      <div className="container mx-auto px-4 py-4 flex items-center justify-between">
        <Link to="/" className="font-display text-2xl font-semibold text-foreground">
          Norte<span className="text-primary">Interiores</span>
        </Link>
        
        <nav className="hidden md:flex items-center space-x-8">
          <Link to="/" className="text-foreground hover:text-primary transition-colors">
            Início
          </Link>
          <Link to="/customizar" className="text-foreground hover:text-primary transition-colors">
            Personalizar
          </Link>
          <a href="#como-funciona" className="text-foreground hover:text-primary transition-colors">
            Como Funciona
          </a>
          <a href="#depoimentos" className="text-foreground hover:text-primary transition-colors">
            Depoimentos
          </a>
        </nav>
        
       <div className="container mx-auto flex h-16 items-center justify-between px-4">
          <h1 className="text-2xl font-bold">Custom Art Creator</h1>
          <LoginDropdown />
        </div>
      </div>
    </header>
  );
}