using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class gol_data {
  private int rows;  // the row dimension
  private int cols;  // the column dimension
  private int corps; // number of coordinate pairs alive at startup
  private int output_mode; // set to:  OUTPUT_NONE, OUTPUT_ASCII, or OUTPUT_VISI
  private int current;
  private Grid grid0;
  private Grid grid1;
  private int isPlaying;
  public delegate void updateAction();
  public static event updateAction onUpdate;
  //private Grid[] board; // 2D array representing board of play

  public gol_data(int rows, int cols, float cellSize) {
    this.rows = rows;
    this.cols = cols;
    this.current = 0;
    this.isPlaying = 0;
    this.grid0 = new Grid(rows, cols, cellSize, 3);
    this.grid1 = new Grid(rows, cols, cellSize, 0);
    //this[0] = grid1;
    //this[1] = grid2;
  }

  public IEnumerator play_gol() {
    if(this.isPlaying == 0) {
      this.isPlaying = 1;
      while (this.isPlaying == 1) {
        yield return new WaitForSeconds(.3f);
        updateBoard();
        if (onUpdate != null) {
          onUpdate();
        }
        //GridColors.staticUpdate();
      }
    } else {
      this.isPlaying = 0;
    }
  }

  public void setState(int x, int y, int state) {
    if (Convert.ToBoolean(this.current)) {
      this.grid1.setState(x,y,state);
    } else {
      this.grid0.setState(x,y,state);
    }
    if (onUpdate != null) {
      onUpdate();
    }
  }

  public int getState(int x, int y) {
    if (Convert.ToBoolean(this.current)) {
      return this.grid1.getState(x,y);
    }
    return this.grid0.getState(x,y);
  }

  public void toString() {
    Debug.Log("Grid0/1: " + rows + "x" + cols);
  }

  public Vector3 GetPosition(int x, int y) {
    if (Convert.ToBoolean(this.current)) {
      return this.grid1.GetPosition(x,y);
    }
    return this.grid0.GetPosition(x,y);
  }

  public void clearBoard() {
    for (int i = 0; i < this.rows; ++i) {
        for (int j = 0; j < this.cols; ++j) {
          this.grid0.setState(i,j, 0);
          this.grid1.setState(i,j, 0);
        }
    }
  }

  public void updateBoard() {
    int lives;

    if (Convert.ToBoolean(this.current)) {

      for (int i = 0; i < this.rows; ++i) {
          for (int j = 0; j < this.cols; ++j) {
            //gets number of live neighbors at given position
            lives = neighbos(i, j);
            //copys values from old board into new
            this.grid0.setState(i,j, this.grid1.getState(i,j));
            //sets new boards positions to dead or alive based on rules
            if (Convert.ToBoolean(this.grid1.getState(i,j))) {
              if (lives != 2 && lives != 3) {
                this.grid0.setState(i,j, 0);
                //total_live--;
              }
            } else if (lives == 3) {
                this.grid0.setState(i,j, 1);
                //total_live++;
            }
            this.grid0.setSortingOrder(i,j,3);
            this.grid1.setSortingOrder(i,j,0);
          }
      }
    } else {
      for (int i = 0; i < this.rows; ++i) {
        for (int j = 0; j < this.cols; ++j) {
          //gets number of live neighbors at given position
          lives = neighbos(i, j);
          //copys values from old board into new
          this.grid1.setState(i,j, this.grid0.getState(i,j));
          //sets new boards positions to dead or alive based on rules
          if (Convert.ToBoolean(this.grid0.getState(i,j))) {
            if (lives != 2 && lives != 3) {
              this.grid1.setState(i,j, 0);
              //total_live--;
            }
          } else if (lives == 3) {
              this.grid1.setState(i,j, 1);
              //total_live++;
          }
          this.grid1.setSortingOrder(i,j,3);
          this.grid0.setSortingOrder(i,j,0);
        }
      }
    }
    if (Convert.ToBoolean(this.current)) {
      this.current = 0;
    } else {
      this.current = 1;
    }

  }

  private int neighbos(int row, int col) {
    int live = 0;
    int tx, ty;
    for (int i = row - 1; i < row + 2; i ++) {
      for (int j = col - 1; j < col + 2; j++) {
        //stores current row and column for use in edge cases
        tx = i;
        ty = j;
        if (i == row && j == col) {
          continue;
        }
        //sets i and j values to loop around the board if position is on edge
        if (i < 0) {
          i = this.rows - 1;
        }
        if (j < 0) {
          j = this.cols - 1;
        }
        if (i >= this.rows) {
          i = 0;
        }
        if (j >= this.cols) {
          j = 0;
        }
        //if the given index is alive, incrament lives
        if (Convert.ToBoolean(this.current)) {
          if (Convert.ToBoolean(this.grid1.getState(i,j))) {
            live++;
          }
        } else {
          if (Convert.ToBoolean(this.grid0.getState(i,j))) {
            live++;
          }
        }
        //resets i and j values to continue the loop
        i = tx;
        j = ty;
      }
    }
    return live;
  }

}
