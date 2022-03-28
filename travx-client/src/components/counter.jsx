import React, { Component } from 'react'


class Counter extends Component {
    state = { 
        count :0
    } 
    // constructor() {
    //     super();
    //     this.handleIncreament = this.handleIncreament.bind(this)
    // }
    handleIncreament = () => {
        this.setState({ count: this.state.count+ 1 });
    }
    handleDecreament = () => {
        this.setState({ count: this.state.count >1 ?  this.state.count-1  : 0 });
    }
    render() { 
        return (
            <div>
                <div className="btn-group" role="button">
                    <button className='btn btn-secondary' onClick={this.handleDecreament}><b> - </b></button>
                    <input type="" className='input-group-text' value={ this.state.count} />
                    <button className='btn btn-secondary' onClick={this.handleIncreament}><b> + </b></button>
                </div>
            </div>
        );
    }
}
 
export default Counter;