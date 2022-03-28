import PropTypes from 'prop-types'
import React, { Component } from 'react'
import Counter from './counter'

export default class JobLists extends Component {
  static propTypes = {}
  state = {
    jobCategory: ["web development", "Accounting", "Sales", "Real State", "Security"]
  }
  renderJobCategories() {
    if (this.state.jobCategory.length === 0) return <p>There no elements in job categories</p>
    return this.state.jobCategory.map(job => <li className='list-group-item'> {job} </li>)
  }
  render() {
    return (
      <React.Fragment>
        <br />
        <Counter></Counter>
        <br />
        
        <div className='my-3 mx-0'>Job Lists</div>
        <ul className='list-group'>
           {this.renderJobCategories()} 
        </ul>
      </React.Fragment>
    )
  }
}

