import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import { Link } from 'react-router-dom';
import { List } from 'react-bootstrap-icons';

export function NavBar() {
  return (
    <Navbar expand="lg" className="bg-body-tertiary">
        <Navbar.Brand href="#home"><List/> Ishy's Marriage CV</Navbar.Brand>
        <Navbar.Toggle aria-controls="basic-navbar-nav" />
        <Navbar.Collapse id="basic-navbar-nav">
          <Nav className="me-auto">
            <Link class='nav-link' to='/home'>Home</Link>
            <Link class='nav-link' to='/about-me'>About Me</Link>
            <Nav.Link href="#link">Education</Nav.Link>
            <Nav.Link href="#link">Fun Questions</Nav.Link>
          </Nav>
        </Navbar.Collapse>
    </Navbar>
  );
}

export default NavBar;