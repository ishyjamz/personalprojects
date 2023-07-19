import Carousel from 'react-bootstrap/Carousel';
import me from '../images/izhush.jpg';
import moreme from '../images/hridoy.png';
import moremore from '../images/grad.jpg';

function Slideshow() {
  return (
    <Carousel data-bs-theme='dark'>
      <Carousel.Item id='carousel'>
        <img src={me} alt=''/>
        <Carousel.Caption>
          <h3>Kids love me! mostly...</h3>
        </Carousel.Caption>
      </Carousel.Item>
      <Carousel.Item>
        <img src={moreme} alt='' />
        <Carousel.Caption>
          <h3>See I told you :)</h3>
        </Carousel.Caption>
      </Carousel.Item>
      <Carousel.Item>
        <img src={moremore} alt='' />
        <Carousel.Caption>
          <h3>Proud moments</h3>
        </Carousel.Caption>
      </Carousel.Item>
    </Carousel>
  );
}

export default Slideshow;