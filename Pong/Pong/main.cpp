#include "main.h"
#include <SFML/Graphics.hpp>
#include "ball.h"
#include "Paddle.h"
#include <sstream>

int main()
{
    sf::VideoMode VM(1280, 720);
    sf::RenderWindow window(VM, "Meow Game");
    sf::Clock clock;
    ball meowBall(1280 / 2, 0);
    sf::Time dt;
    sf::Event event;
    Paddle meowPaddle(1280 / 2, 710);
    float bounceTimer = 0.10f;

    sf::Font font;
    font.loadFromFile("Emulator.ttf");
    sf::Text fontHUD;
    fontHUD.setFont(font);
    fontHUD.setPosition(5, 0);
    fontHUD.setCharacterSize(30);
    fontHUD.setOutlineThickness(2);
    fontHUD.setOutlineColor(sf::Color::Red);
    fontHUD.setFillColor(sf::Color::Green);

    int lives = 3;
    std::stringstream ss;
    ss << "Lives:" << lives;

    fontHUD.setString(ss.str());

    while (window.isOpen()) {
        dt = clock.restart();
        bounceTimer -= dt.asSeconds();

        if (meowBall.getPosition().intersects(meowPaddle.getPosition())) 
        {
            if (bounceTimer < 0) {
                meowBall.hitBall();
                bounceTimer = 0.10f;
            }
        }

        while (window.pollEvent(event))
        {
            if (event.type == sf::Event::Closed)
            {
                window.close();
            }
        }

        if (sf::Keyboard::isKeyPressed(sf::Keyboard::Escape) || lives < 0) {
            window.close();
        } 


        if (sf::Keyboard::isKeyPressed(sf::Keyboard::A))
        {
            meowPaddle.moveLeft();
        }


        else {
            meowPaddle.stopLeft();
        }

        if (sf::Keyboard::isKeyPressed(sf::Keyboard::D))
        {
            meowPaddle.moveRight();
        }


        else {
            meowPaddle.stopRight();
        }


        if (meowBall.getPosition().left < 0 || meowBall.getPosition().left + meowBall.getPosition().width > 1280)
        {
            meowBall.bounceSides();
        }

        if (meowBall.getPosition().top < 0 && bounceTimer < 0)
        {
            meowBall.bounceTop();
            bounceTimer = 0;
        }

        if (meowBall.getPosition().top + meowBall.getPosition().height > 720)
        {
            meowBall.missBottom();
            lives--;
            ss.str("");
            ss << "Lives:" << lives;
            fontHUD.setString(ss.str());
        }

        

        window.clear();
        meowBall.update(dt);
        meowPaddle.update(dt);
        
        
        window.draw(meowBall.getShape());
        window.draw(meowPaddle.getShape());
        window.draw(fontHUD);

        window.display();
    }
}