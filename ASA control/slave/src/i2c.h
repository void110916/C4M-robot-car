#ifndef __I2C_H__
#define __I2C_H__

#include <avr/io.h>

#define F_I2C				25000L
#define TRANSMISSION_SUCCESS -1
#define TRANSMISSION_ERROR	-2
#define BUS_CONNECTED		-3
#define BUS_DISCONNECTED	-4
#define MASTER_TRANSMITTER	0
#define MASTER_RECEIVER		1
#define ACK					0
#define TIMEOUT				50

/*
 * Initialize I2C as bus master
 *
 * I2C frequency should be set at least 16 times less than the slave CPU
 * frequency.
 *
 *     F_I2C = F_CPU / (16 + (2 * TWBR1 * TWSR1_prescalar))
 */
void i2c_Init(void);

/*
 * Transmit start condition
 *
 * I2C commands are initiated by the master with a START condition. A START
 * condition is performed by the master actively pulling SDA low while SCL
 * remains high. After the START condition the bus is busy and can only be used
 * by another master only after a STOP condition is detected.
 *
 * Arguments:
 *      mode    The request control state of the master (transmit or receive).
 *              State of mode will control the R/W bit value.
 *
 * Returns:
 *     Transmission status code.
 */
unsigned char i2c_TX_Start(unsigned char Mode);

/*
 * Transmit slave address
 *
 * Following the START condition the 7-bit slave address is transmitted along
 * with master mode/data direction bit (R/W) as the 8th bit. If the R/W bit is
 * 0 (SDA active low) then the master will write to the slave device. If the
 * R/W bit is 1 (SDA passive high) then the master will read from slave device.
 * The address/direction byte is acknowledged by the slave as the 9th bit.
 *
 * Arguments:
 *     address    7-bit address of slave
 *
 * Returns:
 *     Transmission status code
 */
unsigned char i2c_TX_Address(unsigned char Address);

/*
 * Transmit byte of data
 *
 * Data on the I2C bus is transferred in 8-bit packets. Each byte that is
 * transmitted is acknowledged by the slave in the form of the 9th bit. This
 * bit indicates that the slave device is ready to proceed with the next byte.
 * If the slave device does not acknowledges transfer this  means that there is
 * no more data or the device is not ready for the transfer yet.
 *
 * Arguments:
 *     byteData    Data byte transmitted to slave
 *
 * Returns:
 *     Transmission status code
 */
unsigned char i2c_TX_Byte(unsigned char ByteData);

/*
 * I2C Timeout
 *
 * Returns:
 *     Timeout status
 */
unsigned char i2c_Timeout(void);

/*
 * Receive byte of data
 *
 * Acknowledgement of the data transfer from the slave to master is stored as
 * an ACK (data received) or NACK (data not received). As long as ACK is being
 * reported to the slave after each byte then  the slave will continue sending
 * additional data to the master until NACK is transmitted.
 *
 * Arguments:
 *     acknack    Enable or disable of ACK generation
 *
 * Returns:
 *     One byte of data, or transmission status code
 */
unsigned char i2c_RX_Byte(unsigned char Response);

/*
 * Transmit stop condition
 *
 * Once data frames have been sent the master will issue a STOP condition. Stop
 * conditions are defined by a low to high transition on SDA after a low to
 * high transition on SCL, with SCL remaining high.
 */
void i2c_TX_Stop(void);

#endif